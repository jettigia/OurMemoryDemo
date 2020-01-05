<template>

  <div class="home home-background">
    <div id="main-page">
          
	<div id="center-home-panel" class="container text-center">
		<div class="row">

			<div class="col-md-12 col-sm-12">
				<h3 class="wow bounceIn" data-wow-delay="0.9s">Our Memory</h3>
				<h1 class="wow fadeInUp" data-wow-delay="1.6s">Currently in development.</h1>
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
  height: 90%;
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
  padding: 30px;
  background-color: #ffffffef;
  
}
</style>
