package gambist

import grails.validation.ValidationException

import javax.servlet.http.HttpServletResponse

import static org.springframework.http.HttpStatus.*
import grails.converters.JSON
import grails.converters.XML

class TeamController {

    TeamService teamService

    static allowedMethods = [save: "POST", update: "PUT", delete: "DELETE"]

    def findById(int id) {
        def team = teamService.get(id)
        response.withFormat {
            json { render team as JSON }
            xml { render team as XML }
        }
    }

    def findAll() {
        def teams = teamService.list()
        response.withFormat {
            json { render teams as JSON }
            xml { render teams as XML }
        }
    }

    def add() {
        def team = new Team()
        team.name = request.JSON.name
        team.category = new Category();
        def category = Category.findById(request.JSON.categoryId)
        team.category = category
        teamService.save(team)
        return response.status = HttpServletResponse.SC_CREATED
    }

//    def index(Integer max) {
//        params.max = Math.min(max ?: 10, 100)
//        respond teamService.list(params), model:[teamCount: teamService.count()]
//    }
//
//    def show(Long id) {
//        respond teamService.get(id)
//    }
//
//    def create() {
//        respond new Team(params)
//    }
//
//    def save(Team team) {
//        if (team == null) {
//            notFound()
//            return
//        }
//
//        try {
//            teamService.save(team)
//        } catch (ValidationException e) {
//            respond team.errors, view:'create'
//            return
//        }
//
//        request.withFormat {
//            form multipartForm {
//                flash.message = message(code: 'default.created.message', args: [message(code: 'team.label', default: 'Team'), team.id])
//                redirect team
//            }
//            '*' { respond team, [status: CREATED] }
//        }
//    }
//
//    def edit(Long id) {
//        respond teamService.get(id)
//    }
//
//    def update(Team team) {
//        if (team == null) {
//            notFound()
//            return
//        }
//
//        try {
//            teamService.save(team)
//        } catch (ValidationException e) {
//            respond team.errors, view:'edit'
//            return
//        }
//
//        request.withFormat {
//            form multipartForm {
//                flash.message = message(code: 'default.updated.message', args: [message(code: 'team.label', default: 'Team'), team.id])
//                redirect team
//            }
//            '*'{ respond team, [status: OK] }
//        }
//    }
//
//    def delete(Long id) {
//        if (id == null) {
//            notFound()
//            return
//        }
//
//        teamService.delete(id)
//
//        request.withFormat {
//            form multipartForm {
//                flash.message = message(code: 'default.deleted.message', args: [message(code: 'team.label', default: 'Team'), id])
//                redirect action:"index", method:"GET"
//            }
//            '*'{ render status: NO_CONTENT }
//        }
//    }
//
//    protected void notFound() {
//        request.withFormat {
//            form multipartForm {
//                flash.message = message(code: 'default.not.found.message', args: [message(code: 'team.label', default: 'Team'), params.id])
//                redirect action: "index", method: "GET"
//            }
//            '*'{ render status: NOT_FOUND }
//        }
//    }
}
