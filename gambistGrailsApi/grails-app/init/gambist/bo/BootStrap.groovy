package gambist.bo

import gambist.Bet
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
        def users = createUsers()
        def categoryName = ["Football", "Basketball", "Volleyball", "Rugby", "Tennis"]
        def categories = []
        categoryName.each {
            categories.add(new Category(
                    label: it
            ).save())
        }
        def footballTeams = createFootballTeam(categories[0])
        def matches = createFootballMatches(footballTeams, categories[0])
        def bets = createFootballBet(matches, users)
    }


    private List<Bet> createFootballBet(List<Match> matches, List<User> users) {
        def bets = []
        matches.each { m ->
            Set<Integer> index = []
            8.times {
                index.add(randBetween(0, users.size()-1))
            }
            index.each { userIndex ->
                bets.add(new Bet(
                        user: users[userIndex],
                        match: m,
                        betDate: new Date(),
                        winningRate: 200,
                        betValue: randBetween(2, 20) * 10
                ).save())
            }
        }
    }

    private List<User> createUsers() {
        def firstname = ["Johnatan", "Michael", "Andy", "Jean", "Hillary","Marena","Vinita","Tessy","Florenza","Nicky","Mella","Alissa","Giordano","Kakalina","Rhianon","Bobette","Willabella","Aime","Adrea","Christean","Gaylord","Kiah","Nalani","Honoria","Willis","Aeriell"]
        def lastname = ["Manandraibe", "Ramaroson", "Randrianirina", "Ianiello","Date","Mulvagh","Ceschini","Tolchar","Kerr","Goble","Kuhle","Macguire","Masding","Croose","Broker","Phillimore","Sawl","Dearl","Cowderoy","Broderick","Ubach","Crossley","Yoakley","Gorthy","Braisted"]
        def users = []
        firstname.size().times {
            users.add(new User(
                    email: "${firstname[it].toLowerCase()}@gmail.com",
                    password: 'password',
                    username: firstname[it],
                    dayOfBirth: randomDayOfBirth(),
                    firstname: firstname[it],
                    lastname: lastname[it]
            ).save())
        }
        return users
    }

    private Date randomDayOfBirth() {
        GregorianCalendar gc = new GregorianCalendar();
        int year = randBetween(1970, 2002);
        gc.set(GregorianCalendar.YEAR, year);
        int dayOfYear = randBetween(1, gc.getActualMaximum(GregorianCalendar.DAY_OF_YEAR));
        int month = randBetween(1, 12)
        gc.set(GregorianCalendar.MONTH, month)
        gc.set(gc.DAY_OF_YEAR, dayOfYear);
        return new Date(gc.getTimeInMillis())
    }

    private int randBetween(int start, int end) {
        return start + (int)Math.round(Math.random() * (end - start));
    }

    private List<BetType> createFootballBetType(Category category) {
        def betTypeLabel = ["Ecart de score", "Victoire"]
        def betType = []
        betTypeLabel.each {
            betType.add(new BetType(
                    label: it,
                    category: category
            ).save())
        }
        return betType
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
        20.times {
            int indexA = random.nextInt(footballTeams.size())
            int indexB = random.nextInt((int)(footballTeams.size()/2))
            matches.add(new Match(
                    teamA: footballTeams[indexA],
                    teamB: footballTeams[indexB],
                    category: footballCategory,
                    matchDate: new Timestamp(new Date().getTime() + 7200000 * it)
            ).save())
        }
        return matches
    }

    def destroy = {
    }
}
