package gamebist.bo

class BetType {

    String label
    double currentWinningRate
    static hasOne = [category: Category]

    static constraints = {
    }
}
