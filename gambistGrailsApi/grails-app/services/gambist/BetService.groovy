package gambist

import grails.gorm.services.Service

@Service(Bet)
abstract class BetService {

    abstract Bet get(Serializable id)

    List<Bet> findByDate(Date date) {
        def criteria = Bet.createCriteria()
        def res = criteria.list {
            eq('betDate', date)
        }
        return res
    }

    abstract List<Bet> list(Map args)

    abstract Long count()

    abstract void delete(Serializable id)

    abstract Bet save(Bet bet)

}