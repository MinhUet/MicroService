const path = require('path');

const config = {
    entry: '/wwwroot/reactjs/src/index.js',
    output: {
        filename: 'bundle.js',
        path: path.resolve(__dirname, 'wwwroot/build'),
    }
}

module.exports = config;