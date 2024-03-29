package gambist

class User {

    String email
    String firstname
    String password
    String lastname
    String username
    Date dayOfBirth
    double bankBalance
    static hasMany = [bets: Bet]
    int state

    static constraints = {
        state default: 0
        bankBalance default: 50
    }
}
