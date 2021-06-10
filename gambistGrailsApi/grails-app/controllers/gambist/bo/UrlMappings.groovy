package gambist.bo

class UrlMappings {

    static mappings = {
        "/$controller/$action?/$id?(.$format)?"{
            constraints {
                // apply constraints here
            }
        }

        group '/team', {
            "/by-id/$id"(controller: 'team', action: 'findById')
            "/all"(controller: 'team', action: 'findAll')
        }

        "/"(view:"/index")
        "500"(view:'/error')
        "404"(view:'/notFound')
    }
}
