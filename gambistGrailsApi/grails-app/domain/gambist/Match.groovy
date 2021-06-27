package gambist

import java.sql.Timestamp

class Match {

    Timestamp matchDate
    Team teamA
    Team teamB
    Category category
    int scoreA
    int scoreB
    int state

    static constraints = {
        state default: 0
        scoreA default: 0
        scoreB default: 0
    }
}
