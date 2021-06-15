package gambist.bo

import gambist.BetType
import gambist.Category
import gambist.Match
import gambist.Team
import gambist.User
import grails.converters.JSON

import java.sql.Time
import java.sql.Timestamp

class BootStrap {

    def init = { servletContext ->
        JSON.registerObjectMarshaller(Date) {
            return it?.format("dd.MM.yyyy")
        }
        User user = new User(
                email: 'johnatan@gmail.com',
                password: 'user',
                userName: 'Johnatan',
                dayOfBirth: new Date(),
                firstName: 'Joh',
                lastName: 'Nathan'
        ).save()
        def categoryName = ["Football", "Basketball", "Volleyball", "Rugby", "Tennis"]
        def categories = []
        categoryName.each {
            categories.add(new Category(
                    label: it
            ).save())
        }
        def footballTeams = createFootballTeam(categories[0])
        def matches = createFootballMatches(footballTeams, categories[0])

        BetType betType1 = new BetType(
                label: 'Ecart de score',
                category: categories[1]
        ).save()
        BetType betType2 = new BetType(
                label: 'Victoire',
                category: categories[0]
        )
        BetType betType3 = new BetType(
                label: 'Prochain buteur',
                category: categories[0]
        ).save()

    }

    private List<Team> createFootballTeam(Category footballCategory) {
        def footballTeamsName = ["Borussia Dortmound", "Chelsea", "PSG", "Manchester City", "FC Barcelone", "Liverpool", "Bayern", "Real Madrid", "Juventus", "Inter Milan", "Atlético de Madrid", "FC Porto", "Ajax Amsterdam"]
        def footballTeams = []
        footballTeamsName.each {
            footballTeams.add(new Team(
                    name: it,
                    category: footballCategory
            ).save())
        }
        return footballTeams
    }

    private List<Match> createFootballMatches(List<Team> footballTeams, Category footballCategory) {
        def random = new Random()
        def matches = []
        4.times {
            int indexA = random.nextInt(footballTeams.size())
            int indexB = random.nextInt((int)(footballTeams.size()/2))
            matches.add(new Match(
                    teamA: footballTeams[indexA],
                    teamB: footballTeams[indexB],
                    category: footballCategory,
                    matchDate: new Timestamp(new Date().getTime())
            ).save())
        }
        return matches
    }

    def destroy = {
    }
}
