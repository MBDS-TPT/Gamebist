package gambist

class User {

    String email
    String firstName
    String password
    String lastName
    String userName
    Date dayOfBirth
    static hasMany = [bets: Bet]
    int state

    static constraints = {
        state default: 0
    }
}
