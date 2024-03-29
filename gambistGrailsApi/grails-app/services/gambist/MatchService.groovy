package gambist

import grails.gorm.services.Service

@Service(Match)
abstract class MatchService {

    abstract Match get(Serializable id)

    Object list(Map args) {
        def max = args && args.max ? Integer.parseInt(args.max) : 10
        def offset = args && args.page ? Integer.parseInt(args.page) * max : 0
        def criteria = Match.createCriteria()
        def res =  criteria.list(max: max, offset: offset) {
            eq('state', State.CREATED)
            if(args.teamAId)
                eq('teamA.id', Long.parseLong(args.teamAId))
            if(args.teamBId)
                eq('teamB.id', Long.parseLong(args.teamBId))
            if(args.categoryId)
                eq('category.id', Long.parseLong(args.categoryId))
            if(args.date1 && args.date2)
                between('matchDate', args.date1, args.date2)
            else {
                if(args.date1)
                    gte('matchDate', args.date1)
                else if(args.date2) {
                    lte('matchDate', args.date2)
                }
            }
            order('matchDate', 'desc')
        }
        return [data: res, totalCount: res.getTotalCount()]
    }

    List getAllMatchId() {
        def criteria = Match.createCriteria();
        def matches = criteria.list {
            eq('state', State.CREATED)
        }
        def ids = []
        matches.each {
            ids.add(it.id)
        }
        return ids
    }

    List<Match> getUpcomingMatchByCategory(long categoryId) {
        def criteria = Match.createCriteria()
        return criteria.list() {
            eq('state', State.CREATED)
            eq('category.id', categoryId)
            gte('matchDate', new Date())
        }
    }

    List<Match> getLatestMatchResult(int count) {
        def criteria = Match.createCriteria()
        return criteria.list(max: count) {
            eq('state', State.CREATED)
            lt('matchDate', new Date())
            order('matchDate', 'desc')
        }
    }

    List<Match> getPopularMatches(int count) {
        return criteria.list(max: count) {
            eq('state', State.CREATED)
            projections {
                groupProperty('match')
                count()
                'match' {
                    gte('matchDate', new Date())
                }
            }
            order('betCount', 'desc')
        }
    }

    Map<String, List<Match>> getUpcomingMatchGroupedByCategory() {
        def categories = Category.createCriteria().list {
            eq('state', State.CREATED)
        }
        def data = [:]
        categories.each {
            data.put(it.label, this.getUpcomingMatchByCategory(it.id))
        }
        return data
    }

    abstract Long count()

    abstract void delete(Serializable id)

    abstract Match save(Match match)

}