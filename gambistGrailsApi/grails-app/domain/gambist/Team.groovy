package gambist

class Team {

    String name
    Category category
    int state

    static fetchMode = [category: "eager"]

    static constraints = {
        state default: 0
    }
}
