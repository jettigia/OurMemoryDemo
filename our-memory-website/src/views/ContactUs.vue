<template>
  <div class="home home-background">
    <div id="main-page">
      <div id="center-home-panel" class="container text-center">
        <!-- About section  -->
        <section class="about-section" style="text-align:left;">
          <form action="/action_page.php">
    <h1>Contact Us</h1>
<br>
    <label for="fname">First Name</label>
<br>
    <input type="text" id="fname" name="firstname" placeholder="Your name..">
<br>
    <label for="lname">Last Name</label>
    <br>
    <input type="text" id="lname" name="lastname" placeholder="Your last name..">
<br>
    <label for="lname">Email</label>
    <br>
    <input type="text" id="email" name="lastname" placeholder="Your email..">
<br>
    <label for="subject">Message</label>
<br>
    <textarea id="subject" name="subject" placeholder="Write something.." style="height:200px"></textarea>
<br>
    <input class="btn btn-secondary btn-lg" type="submit" value="Submit">

  </form>
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
  bottom: 10%;
  top: 15%;
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