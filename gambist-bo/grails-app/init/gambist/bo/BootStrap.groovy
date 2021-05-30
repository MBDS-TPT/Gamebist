package gambist.bo

import gambist.BetType
import gambist.Category
import gambist.Team
import gambist.User

class BootStrap {

    def init = { servletContext ->
        User user = new User(
                email: 'johnatan@gmail.com',
                password: 'user',
                userName: 'Johnatan',
                dayOfBirth: new Date(),
                firstName: 'Joh',
                lastName: 'Nathan'
        ).save()
        Category catFootball = new Category(
                label: 'Football',
        ).save()
        Category catBasketball = new Category(
                label: 'Basletball'
        ).save()

        BetType betType1 = new BetType(
                label: 'Ecart de score',
                category: catBasketball
        ).save()
        BetType betType2 = new BetType(
                label: 'Victoire',
                category: catFootball
        )
        BetType betType3 = new BetType(
                label: 'Prochain buteur',
                category: catFootball
        ).save()
        Team team1 = new Team(
                name: 'Chelsea',
                category: catFootball
        ).save()
        Team team2 = new Team(
                name: 'Manchester City',
                category: catFootball
        ).save()
    }
    def destroy = {
    }
}
