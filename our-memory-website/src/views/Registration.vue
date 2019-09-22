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
        > <b-form-input
            id="emailInput"
            v-model="form.email"
            type="email"
            required
            placeholder="Enter email"
          ></b-form-input>
        </b-form-group>

        <b-form-group id="name.Label" label="Your Name:" label-for="nameInput">
          <b-form-input
            id="nameInput"
            v-model="form.name"
            required
            placeholder="Enter name"
          ></b-form-input>
        </b-form-group>

        <b-form-group id="passwordLabel" label="Password:" label-for="passwordInput">
          <b-form-input
            id="passwordInput"
            v-model="form.password"
            required
            placeholder="Enter password"
            type="password"
          ></b-form-input>
        </b-form-group>

        <b-form-group
          id="confirmPasswordLabel"
          label="Confirm Password:"
          label-for="input-3"
        ><b-form-input
            id="confirmPasswordInput"
            v-model="form.confirmPassword"
            required
            placeholder="Confirm password"
            type="password"
          ></b-form-input>
        </b-form-group>

        <b-button type="submit" variant="primary">Submit</b-button>
        <b-button type="reset" variant="danger">Reset</b-button>
      </b-form>
      <b-card class="mt-3" header="Form Data Result">
        <pre class="m-0">{{ form }}</pre>
      </b-card>
    </div>
  </div>
</template>

<script>
import axios from "axios";
import ApiService from "..\\components\\ApiService.vue";

export default {
  data() {
    return {
      form: {
        email: "",
        name: "",
        confirmPassword: "",
        password: ""
      },
      show: true
    };
  },
  methods: {
    async onSubmit(evt) {
      evt.preventDefault();

      var result = await ApiService.post("Account\\Register", this.form);

      if (result.status == 200) {
        console.log("success: " + result.data);
      } else { 
        console.log("failure:" + result.status + " | " + result.data);
      }
          
      alert(JSON.stringify(this.form));
    },
    onReset(evt) {
      evt.preventDefault();
      // Reset our form values
      this.form.email = "";
      this.form.name = "";
      this.form.food = null;
      this.form.checked = [];
      // Trick to reset/clear native browser form validation state
      this.show = false;
      this.$nextTick(() => {
        this.show = true;
      });
    }
  }
};
</script>
