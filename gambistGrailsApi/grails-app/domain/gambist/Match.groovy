package gambist

class Match {

    Date matchDate
    Team teamA
    Team teamB
    Category category
    int state

    static constraints = {
        state default: 0
    }
}
