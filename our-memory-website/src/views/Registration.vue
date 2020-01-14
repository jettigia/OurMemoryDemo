<template>

<div class="home home-background">
    <div id="main-page">
          
	<div id="center-home-panel" class="container text-center">

  <div class="registration" style="text-align: center;">
    <h1>Registration</h1>
    <div style="width: 50%; left: 25%; display: inline-block">
      <b-form @submit="onSubmit" @reset="onReset" v-if="show">
        <b-form-group
          id="emailLabel"
          label="Email address:"
          label-for="emailInput"
          description="We'll never share your email with anyone else."
        >
          <b-form-input
            id="emailInput"
            v-model="model.email"
            type="email"
            required
            placeholder="Enter email"
          ></b-form-input>
        </b-form-group>

      <b-form-group id="firstName.Label" label="First Name:" label-for="firstNameInput">
          <b-form-input
            id="firstNameInput"
            v-model="model.firstName"
            required
            placeholder="Enter first name"
          ></b-form-input>
        </b-form-group>

        <b-form-group id="lastName.Label" label="Last Name:" label-for="lastNameInput">
          <b-form-input
            id="lastNameInput"
            v-model="model.lastName"
            required
            placeholder="Enter last name"
          ></b-form-input>
        </b-form-group>

        <b-form-group id="username.Label" label="Username:" label-for="username">
          <b-form-input
            id="username"
            v-model="model.username"
            required
            placeholder="Enter username"
          ></b-form-input>
        </b-form-group>

        <b-form-group
          id="passwordLabel"
          label="password:"
          label-for="passwordInput"
        >
          <b-form-input
            id="passwordInput"
            v-model="model.password"
            required
            placeholder="Enter password"
            type="password"
          ></b-form-input>
        </b-form-group>

        <b-form-group
          id="confirmpasswordLabel"
          label="Confirm password:"
          label-for="input-3"
          ><b-form-input
            id="confirmpasswordInput"
            v-model="model.confirmPassword"
            required
            placeholder="Confirm password"
            type="password"
          ></b-form-input>
        </b-form-group>

        <b-button class="btn btn-lg btn-default smoothScroll wow fadeInUp" type="submit" variant="primary">Submit</b-button>
        <!-- <b-button class="btn btn-lg btn-default smoothScroll wow fadeInUp" type="reset" variant="danger">Reset</b-button> -->
      </b-form>
    </div>
  </div>

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
  
  height: 90%;
  /* padding-bottom: 0px 0px 19px 0px; */
}
#center-home-panel {
  
  position: absolute;
  margin: auto;
     
  right: 0;
  left: 0;
  
  top: 10%;

  width: 70%;
  padding: 30px;
  background-color: #ffffffef;
  
}
</style>

<script>
import UserService from "@/components/user-service";

export default {
  data() {
    return {
      model: {
        email: '',
        firstName: '',
        lastName: '',
        username: '',
        confirmPassword: '',
        password: ''
      },
      show: true
    };
  },
  async mounted() {
    console.log('Registration Version 1.0.0.5');
    var service = new UserService();
    var result = await service.getVersion();
    console.log(result.data);
  },
  methods: {
    async onSubmit(evt) {
     evt.preventDefault();

  if (this.model.password != this.model.confirmPassword) {
    return;
  }

      var service = new UserService();
      var result = await service.register({
        "email": this.model.email,
        "firstName": this.model.firstName,
        "lastName": this.model.lastName,
        "username": this.model.username,
        "password": this.model.password
      });

      this.model.password = '';

      if (result.status == 200) {
        this.$router.push('registration-success');
      } else {
        // Todo: Display errors. Do not re-route.
        this.$router.push('registration-unsuccess');
      }
    },
    onReset(evt) {
      evt.preventDefault();
      // Reset our form values
      this.model.email = "";
      this.model.name = "";
      // Trick to reset/clear native browser form validation state
      this.show = false;
      this.$nextTick(() => {
        this.show = true;
      });
    }
  }
};
</script>

