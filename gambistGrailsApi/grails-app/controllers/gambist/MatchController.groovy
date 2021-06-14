package gambist

import grails.core.GrailsApplication
import grails.validation.ValidationException
import org.springframework.beans.factory.annotation.Autowired

import javax.servlet.http.HttpServletResponse
import java.sql.Timestamp
import java.text.DateFormat
import java.text.SimpleDateFormat

import static org.springframework.http.HttpStatus.*
import grails.converters.JSON

class MatchController {

    MatchService matchService
    TeamService teamService
    CategoryService categoryService

    @Autowired
    GrailsApplication grailsApplication

    static allowedMethods = [save: "POST", update: "PUT", delete: "DELETE"]

    def all() {
        def matches = matchService.list()
        JSON.use('deep') {
            render matches as JSON
        }
    }

    def add() {
        if(!request.getMethod().equalsIgnoreCase("POST"))
            return HttpServletResponse.SC_METHOD_NOT_ALLOWED
        def dateFormat = grailsApplication.config.getProperty("date.format")
        def df = new SimpleDateFormat(dateFormat)
        def date = new Timestamp(df.parse(request.JSON.matchDate).getTime())
        println(date)
        if(!request.JSON.teamAId || !request.JSON.teamBId || !request.JSON.categoryId || !date)
            return HttpServletResponse.SC_BAD_REQUEST
        def match = new Match(
                category: categoryService.get(request.JSON.categoryId),
                teamA: teamService.get(request.JSON.teamAId),
                teamB: teamService.get(request.JSON.teamBId),
                matchDate: date
        )
        match = matchService.save(match)
        JSON.use(('deep'))  {
            render match as JSON
        }
    }
}
