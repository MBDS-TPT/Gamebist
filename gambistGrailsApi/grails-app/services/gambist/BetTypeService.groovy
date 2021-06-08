package gambist

import grails.gorm.services.Service

@Service(BetType)
interface BetTypeService {

    BetType get(Serializable id)

    List<BetType> list(Map args)

    Long count()

    void delete(Serializable id)

    BetType save(BetType betType)

}