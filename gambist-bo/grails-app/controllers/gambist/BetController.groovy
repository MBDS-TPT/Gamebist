package gambist

import grails.validation.ValidationException
import static org.springframework.http.HttpStatus.*

class BetController {

    BetService betService

    static allowedMethods = [save: "POST", update: "PUT", delete: "DELETE"]

    def index(Integer max) {
        params.max = Math.min(max ?: 10, 100)
        respond betService.list(params), model:[betCount: betService.count()]
    }

    def show(Long id) {
        respond betService.get(id)
    }

    def create() {
        respond new Bet(params)
    }

    def save(Bet bet) {
        if (bet == null) {
            notFound()
            return
        }

        try {
            betService.save(bet)
        } catch (ValidationException e) {
            respond bet.errors, view:'create'
            return
        }

        request.withFormat {
            form multipartForm {
                flash.message = message(code: 'default.created.message', args: [message(code: 'bet.label', default: 'Bet'), bet.id])
                redirect bet
            }
            '*' { respond bet, [status: CREATED] }
        }
    }

    def edit(Long id) {
        respond betService.get(id)
    }

    def update(Bet bet) {
        if (bet == null) {
            notFound()
            return
        }

        try {
            betService.save(bet)
        } catch (ValidationException e) {
            respond bet.errors, view:'edit'
            return
        }

        request.withFormat {
            form multipartForm {
                flash.message = message(code: 'default.updated.message', args: [message(code: 'bet.label', default: 'Bet'), bet.id])
                redirect bet
            }
            '*'{ respond bet, [status: OK] }
        }
    }

    def delete(Long id) {
        if (id == null) {
            notFound()
            return
        }

        betService.delete(id)

        request.withFormat {
            form multipartForm {
                flash.message = message(code: 'default.deleted.message', args: [message(code: 'bet.label', default: 'Bet'), id])
                redirect action:"index", method:"GET"
            }
            '*'{ render status: NO_CONTENT }
        }
    }

    protected void notFound() {
        request.withFormat {
            form multipartForm {
                flash.message = message(code: 'default.not.found.message', args: [message(code: 'bet.label', default: 'Bet'), params.id])
                redirect action: "index", method: "GET"
            }
            '*'{ render status: NOT_FOUND }
        }
    }
}