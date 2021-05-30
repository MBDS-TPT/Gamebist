package gambist

import grails.validation.ValidationException
import static org.springframework.http.HttpStatus.*

class BetTypeController {

    BetTypeService betTypeService

    static allowedMethods = [save: "POST", update: "PUT", delete: "DELETE"]

    def index(Integer max) {
        params.max = Math.min(max ?: 10, 100)
        respond betTypeService.list(params), model:[betTypeCount: betTypeService.count()]
    }

    def show(Long id) {
        respond betTypeService.get(id)
    }

    def create() {
        respond new BetType(params)
    }

    def save(BetType betType) {
        if (betType == null) {
            notFound()
            return
        }

        try {
            betTypeService.save(betType)
        } catch (ValidationException e) {
            respond betType.errors, view:'create'
            return
        }

        request.withFormat {
            form multipartForm {
                flash.message = message(code: 'default.created.message', args: [message(code: 'betType.label', default: 'BetType'), betType.id])
                redirect betType
            }
            '*' { respond betType, [status: CREATED] }
        }
    }

    def edit(Long id) {
        respond betTypeService.get(id)
    }

    def update(BetType betType) {
        if (betType == null) {
            notFound()
            return
        }

        try {
            betTypeService.save(betType)
        } catch (ValidationException e) {
            respond betType.errors, view:'edit'
            return
        }

        request.withFormat {
            form multipartForm {
                flash.message = message(code: 'default.updated.message', args: [message(code: 'betType.label', default: 'BetType'), betType.id])
                redirect betType
            }
            '*'{ respond betType, [status: OK] }
        }
    }

    def delete(Long id) {
        if (id == null) {
            notFound()
            return
        }

        betTypeService.delete(id)

        request.withFormat {
            form multipartForm {
                flash.message = message(code: 'default.deleted.message', args: [message(code: 'betType.label', default: 'BetType'), id])
                redirect action:"index", method:"GET"
            }
            '*'{ render status: NO_CONTENT }
        }
    }

    protected void notFound() {
        request.withFormat {
            form multipartForm {
                flash.message = message(code: 'default.not.found.message', args: [message(code: 'betType.label', default: 'BetType'), params.id])
                redirect action: "index", method: "GET"
            }
            '*'{ render status: NOT_FOUND }
        }
    }
}
