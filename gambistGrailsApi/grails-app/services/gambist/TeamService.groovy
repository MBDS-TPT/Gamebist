package gambist

import grails.gorm.services.Service

@Service(Team)
abstract class TeamService {

    abstract Team get(Serializable id)

//    abstract List<Team> list(Map args)

    List<Team> list() {
        return Team.findAllByState(State.CREATED)
    }

    abstract Long count()

    abstract void delete(Serializable id)

    abstract Team save(Team team)

}