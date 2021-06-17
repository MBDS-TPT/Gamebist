package gambist

import utils.DateUtil

import javax.servlet.http.HttpServletResponse
import java.sql.Timestamp

import grails.converters.JSON

class MatchController {

    MatchService matchService
    TeamService teamService
    CategoryService categoryService
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
        def date = new Timestamp(DateUtil.toDate(request.JSON.matchDate).getTime())
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

    def edit() {
        if(!request.getMethod().equalsIgnoreCase("PUT"))
            return HttpServletResponse.SC_METHOD_NOT_ALLOWED
        def date = new Timestamp(DateUtil.toDate(request.JSON.matchDate).getTime())
        if(!request.JSON.teamAId || !request.JSON.teamBId || !request.JSON.categoryId || !date)
            return HttpServletResponse.SC_BAD_REQUEST
        def match = matchService.get(request.JSON.id)
        if(!match)
            return response.status = HttpServletResponse.SC_NOT_FOUND
        match.category = categoryService.get(request.JSON.categoryId)
        match.teamA = teamService.get(request.JSON.teamAId)
        match.teamB = teamService.get(request.JSON.teamBId)
        match.matchDate = date
        matchService.save(match)
        JSON.use("deep") {
            render match as JSON
        }
    }

    def delete() {
        if(!request.getMethod().equalsIgnoreCase("DELETE"))
            return HttpServletResponse.SC_METHOD_NOT_ALLOWED
        if(!request.JSON.id)
            return response.status = HttpServletResponse.SC_BAD_REQUEST
        def match = matchService.get(request.JSON.id)
        match.state = State.DELETED
        matchService.save(match);
        JSON.use("deep") {
            render match as JSON
        }
    }
}
