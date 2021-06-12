package gambist

class Team {

    String name
    Category category
    int state

    static constraints = {
        state default: 0
    }

}
