package gambist

import grails.gorm.services.Service

@Service(Bet)
interface BetService {

    Bet get(Serializable id)

    List<Bet> list(Map args)

    Long count()

    void delete(Serializable id)

    Bet save(Bet bet)

}