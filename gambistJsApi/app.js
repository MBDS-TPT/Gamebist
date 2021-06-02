let express = require('express');
let app = express();

let port = process.env.PORT || 8010;

app.listen(port, "0.0.0.0");
console.log('Serveur démarré sur http://localhost:' + port);