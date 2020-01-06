// vue.config.js
module.exports = {
  devServer: {
    proxy: {
      "/api/*": {
          target: "https://localhost:44399",
          changeOrigin: true,
          secure: true,
          pathRewrite: {
            '^/api': ''
            }
      }
  }
  },
  configureWebpack: {
    devtool: "source-map"
  }
};
