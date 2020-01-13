<template>

  <div class="home home-background">
    <div id="main-page">
          
	<div id="center-home-panel" class="container text-center">
    
    <!-- About section  -->
	<section class="about-section">
		<div class="container-fluid">
			<div class="row">
				<!-- <div class="col-lg-6 p-0">
					<div class="about-bg set-bg" ><img src="../assets/faviconORIG.png" width="50%"></div>
				</div> -->
				<div class="grid-container">

					<div >
						<img src="../assets/faviconORIG.png" width="50%">
					</div>

					<div >
						<br>
						<h2>About Our Memory</h2>
						<p>Our Memory is dedicated to storing and protecting your memories. </p>
						<!-- <h4>Info 1</h4>
						<p>Quis ipsum suspendisse ultrices gravida. Risus commodo viverra maecenas ac-cusan. </p>
						<h4>Info 2</h4>
						<p>Quis ipsum suspendisse ultrices gravida. Risus commodo viverra maecenas ac-cusan lacus vel facilisis.</p> -->
						<a href="#" class="site-btn">contact us</a>
					</div>
				</div>
			</div>
		</div>
	</section>
	<!-- About section end  -->

  </div>
  </div>
  </div>
</template>


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

.grid-container {
  display: grid;
  grid-template-columns: auto auto auto auto;
  grid-gap: 10px;
}

</style>