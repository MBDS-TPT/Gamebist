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
                int j = 24 * 60 * 60 * 1000
                def date = new java.sql.Date(System.currentTimeMillis() + (j * randBetween(0, 2)))
                println("### " + date)
                bets.add(new Bet(
                        user: users[userIndex],
                        match: m,
                        betDate: date,
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
        def footballTeams_ = [
                "Borussia Dortmound":"https://www.pngitem.com/pimgs/m/35-350698_transparent-bvb-logo-png-borussia-dortmund-logo-png.png",
                "Chelsea":"https://i.pinimg.com/736x/b9/22/c4/b922c4e18a85eeb707bf73423033442b.jpg",
                "PSG":"https://lh3.googleusercontent.com/dtFuCbfBxODq263Ramrmu-7jXxjsdL2YdyXA243PtwLr2U5xOAaUi63FwSgDRKuNTXCyPEyghjW-D2EVlfjnp4HU",
                "Manchester City":"https://lh3.googleusercontent.com/KNyKMfQqqVcLYAROYJ6KPW7nqmyMMcuc7npdzuzYI9KXhnZDJ3Wkfqy_apcQTDgq2QlNp9LzqQly06N5qsNxUOLT",
                "FC Barcelone":"https://lh3.googleusercontent.com/OQZi4ckWAs7UrOlZEPefXZgJOcdJuSM5FSH9zqD5rMg6c2MOaxcKpV5IMrb1Tju98fWyNmcI33E4RGb0uC09Ej4W",
                "Bayern":"https://cdn.1min30.com/wp-content/uploads/2018/03/Logo-Bayern-Munich-1.jpg",
                "Real Madrid":"https://upload.wikimedia.org/wikipedia/fr/thumb/c/c7/Logo_Real_Madrid.svg/1200px-Logo_Real_Madrid.svg.png",
                "Juventus":"https://www.ecofoot.fr/wp-content/uploads/2017/01/nouveau-logo-juventus.jpg",
                "Inter Milan":"https://assets-fr.imgfoot.com/media/cache/1200x900/nouveau-logo-inter-milan-img1.jpg",
                "Liverpool":"https://kgo.googleusercontent.com/profile_vrt_raw_bytes_1587515361_10542.jpg",
                "Atlético de Madrid":"https://upload.wikimedia.org/wikipedia/fr/thumb/9/93/Logo_Atl%C3%A9tico_Madrid_2017.svg/1200px-Logo_Atl%C3%A9tico_Madrid_2017.svg.png",
                "FC Porto":"https://upload.wikimedia.org/wikipedia/fr/thumb/6/65/FC_Porto_Vitalis_logo.svg/1200px-FC_Porto_Vitalis_logo.svg.png",
                "Ajax Amsterdam":"https://upload.wikimedia.org/wikipedia/fr/7/77/Ajax_Amsterdam_Logo.svg",
                "Tottenham":"https://kgo.googleusercontent.com/profile_vrt_raw_bytes_1587515401_10891.jpg"
        ]
        def footballTeams = []
        def keys = footballTeams_.keySet()
        keys.each {
            footballTeams.add(new Team(
                    name: it,
                    category: footballCategory,
                    logo: footballTeams_[it]
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
