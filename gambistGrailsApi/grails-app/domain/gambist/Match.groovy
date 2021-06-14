package gambist

import java.sql.Timestamp

class Match {

    Timestamp matchDate
    Team teamA
    Team teamB
    Category category
    int state

    static constraints = {
        state default: 0
    }
}
