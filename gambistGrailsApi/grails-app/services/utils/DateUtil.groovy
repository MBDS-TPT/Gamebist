package utils

import grails.core.GrailsApplication
import grails.gorm.services.Service
import org.springframework.beans.factory.annotation.Autowired

import java.text.SimpleDateFormat

class DateUtil {

    static final String DATE_FORMAT = 'yyyy-MM-dd\'T\'HH:mm:ss.SSSX'

    static toDate(date) {
        def sdf = new SimpleDateFormat(DateUtil.DATE_FORMAT)
        sdf.setTimeZone(TimeZone.getTimeZone('GMT'));
        return sdf.parse(date)
    }

}
