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

    abstract Long count()

    abstract void delete(Serializable id)

    abstract Match save(Match match)

}