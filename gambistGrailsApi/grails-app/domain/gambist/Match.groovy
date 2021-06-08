package gambist

class Match {

    Date matchDate
    Team teamA
    Team teamB
    int state

    static constraints = {
        state default: 0
    }
}
