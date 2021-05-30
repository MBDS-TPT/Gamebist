package gamebist.bo

class Bet {

    double betValue
    Date betDate
    double winningRate
    static hasOne = [betType: BetType, user: User]

    static constraints = {
    }
}
