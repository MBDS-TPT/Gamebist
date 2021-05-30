package gamebist.bo

class Team {

    String teamName
    static hasOne = [category: Category]
    static belongsTo = [match: Match]

    static constraints = {
    }
}
