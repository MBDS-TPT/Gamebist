package gambist

class Bet {

    double betValue
    Date betDate
    double winningRate
    BetType betType
    static belongsTo = [user: User]
    int state

    static constraints = {
        state default: 0
        betDate default: new Date()
    }
}
