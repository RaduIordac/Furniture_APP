const PROXY_CONFIG = [
  {
    context: [
      "/weatherforecast",
      
    ],
    target: "https://localhost:7150; https://localhost:4200; https://127.0.0.1:4200",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
