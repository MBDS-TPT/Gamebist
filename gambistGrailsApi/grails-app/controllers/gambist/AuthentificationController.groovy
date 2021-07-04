package gambist

import gambist.UserService
import grails.converters.JSON

import javax.servlet.http.HttpServletResponse

class AuthentificationController {

    UserService userService

    def login() {
        def login = request.JSON.username
        def password = request.JSON.password
        if(!login || !password)
            return response.status = HttpServletResponse.SC_BAD_REQUEST
        def user = userService.login(login, password)
        if(user) {
            JSON.use('deep') {
                render user as JSON
            }
        } else {
            return response.status = HttpServletResponse.SC_NOT_FOUND
        }
    }
}
