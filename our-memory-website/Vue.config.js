// vue.config.js
module.exports = {
  devServer: {
    proxy: process.env.BASE_URL || "https://localhost:44349/"
  },
  configureWebpack: {
    devtool: "source-map"
  }
};
