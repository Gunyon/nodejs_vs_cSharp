// Node.js server (app.js)
const http = require('http');
const fs = require('fs');

const server = http.createServer((req, res) => {
  // Asynchronously read a file
  fs.readFile('example.txt', 'utf8', (err, data) => {
    if (err) {
      res.writeHead(500, { 'Content-Type': 'text/plain' });
      res.end('Server Error');
      return;
    }
    res.writeHead(200, { 'Content-Type': 'text/plain' });
    res.end(data);
  });
});

server.listen(3000, () => {
  console.log('Node.js server running at http://localhost:3000');
});
