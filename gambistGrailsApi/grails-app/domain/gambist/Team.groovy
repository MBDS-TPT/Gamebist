package gambist

class Team {

    String name
    Category category
    String logo
    int state

    static constraints = {
        state default: 0
        logo nullable: true
    }

}
