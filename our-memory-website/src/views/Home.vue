<template>
  <div class="home home-background">
    <div id="main-page">
      <div id="center-home-panel" class="container text-center">
        <div class="">
          <div class="" style="top: 50%;">
            <h3 class="wow bounceIn" data-wow-delay="0.9s">Welcome!</h3>
            <h2 class="wow fadeInUp" data-wow-delay="1.6s">
              Our Memory is currently in development:
            </h2>
            <base href="/" />
            <h4></h4>
            <br />
            <router-link
              to="/about"
              class="btn btn-lg btn-default smoothScroll wow fadeInUp "
              >LEARN MORE</router-link
            >
            <router-link
              to="/registration"
              class="btn btn-lg btn-danger smoothScroll wow fadeInUp"
              >Try Now</router-link
            >
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

//SCRIPTS -----------------------------------------------------------------

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";

@Component({
  components: {}
})
export default class Home extends Vue {}
</script>

//STYLE -----------------------------------------------------------------

<style scoped>
home-html {
  /* height: 100%; */
  background-color: #cccccc;
}
.home {
  background-image: url("../assets/home-background-image.jpg");
  background-size: cover;
  height: 100%;
  /* padding-bottom: 0px 0px 19px 0px; */
}
#center-home-panel {
  position: absolute;
  margin: auto;

  right: 0;
  left: 0;
  bottom: 30%;
  top: 35%;

  width: 70%;
  /* height: 50%; */
  padding: 30px;
  background-color: #ffffffef;
}
</style>
