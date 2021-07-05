package gambist

class Bet {

    double betValue
    Date betDate
    double winningRate
    BetType betType
    Match match
    Team team
    static belongsTo = [user: User]
    int state

    static constraints = {
        state default: 0
        betDate default: new Date()
        betType nullable: true
        team nullable: true
    }
}
