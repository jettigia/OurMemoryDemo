<template>
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

        <b-button type="submit" variant="primary">Submit</b-button>
        <b-button type="reset" variant="danger">Reset</b-button>
      </b-form>
    </div>
  </div>
</template>

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

      if (result.status == 200) {
        console.log("success: " + result.data);
      } else {
        console.log("failure:" + result.status + " | " + result.data);
      }

      alert(JSON.stringify(this.model));
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
