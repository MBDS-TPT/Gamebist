package gambist

import grails.gorm.services.Service

@Service(Match)
abstract class MatchService {

    abstract Match get(Serializable id)

    List<Match> list(Map args) {
        def max = args && args.max ? args.max : 20
        def offset = args && args.offset ? args.offset : 0
        def criteria = Match.createCriteria()
        def res =  criteria.list(max: max, offset: offset) {
            eq('state', State.CREATED)
            order('matchDate', 'desc')
        }
        return Match.list()
    }

    abstract Long count()

    abstract void delete(Serializable id)

    abstract Match save(Match match)

}