<template>
  <div class="home home-background">
    <div id="main-page">
      <div id="center-home-panel" class="container text-center">
        <!-- About section  -->
        <section>
          <div>
            <div>
              <div>
                <h1><font size="60">✔</font></h1>
              </div>

              <div>
                <br />
                <h2>Success!</h2>
                <p>You have been successfully registered to Our Memory.</p>
                <p>Please login at the top to continue.</p>
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
