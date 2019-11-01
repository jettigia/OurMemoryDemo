<template>
  <div class="home home-background">
    <img alt="Our Memory logo" src="../assets/logo.png" height="5%" width="5%" />
    <img alt="Our Memory background" src="../assets/home-background-image.jpg" height="25%" width="25%" />
    <body>Welcome!</body>
  </div>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";

@Component({
  components: {}
})
export default class Home extends Vue {}
</script>

<style scoped>
home-background {
  background-image: url("/src/assets/home-background-image.jpg");
  background-color: #cccccc;
}
</style>
