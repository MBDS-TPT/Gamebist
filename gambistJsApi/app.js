//Mise en place d'Express
let express = require('express');
let app = express();

//Mise en place de Mongoose
let mongoose = require('mongoose');
mongoose.Promise = global.Promise;
let dbConfig = require('./config/database');
mongoose.connect(dbConfig.db, {
    useNewUrlParser: true,
    useUnifiedTopology: true,
    useCreateIndex: true,
    useFindAndModify: false,
  }).then(() => {
    console.log('Connected to database');
  },
    error => {
      console.log('Could not connect to databse : ' + error);
    }
  )

//Pour accepter les connexions cross-domain (CORS)
app.use(function (req, res, next) {
    res.header("Access-Control-Allow-Origin", "*");
    res.header("Access-Control-Allow-Headers", "Origin, X-Requested-With, Content-Type, Accept");
    res.header("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE, OPTIONS");
    next();
});

//Pour les formulaires
app.use(express.urlencoded({ extended: true }));
app.use(express.json());

let port = process.env.PORT || 8010;

app.listen(port, "0.0.0.0");
console.log('Serveur démarré sur http://localhost:' + port);