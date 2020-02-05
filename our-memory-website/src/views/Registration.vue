<template>
  <div class="home home-background">
    <div id="main-page">
      <div id="center-home-panel" class="container text-center">
        <div
          id="modalImage1"
          class="modal fade"
          tabindex="-1"
          role="dialog"
          aria-labelledby="myModalLabel"
          aria-hidden="true"
        >
          <div class="modal-dialog">
            <div class="modal-content">
              <div class="modal-header">
                <button
                  type="button"
                  class="close font-weight-light"
                  data-dismiss="modal"
                  aria-hidden="true"
                >
                  ×
                </button>
              </div>
              <div class="modal-body">
                <!-- Terms o service -->
                <h2>OurMemory Terms and Conditions</h2>
                <h3>Terms and Conditions ("Terms")</h3>
                <p>Last updated: 1/17/2020</p>
                <br>
                <p>Please read these Terms and Conditions ("Terms", "Terms and Conditions") carefully before using the http://www.ourmemory.com website and the OurMemory mobile application (the "Service") operated by OurMemory.</p>
                <br>
                <p>Your access to and use of the Service is conditioned on your acceptance of and compliance with these Terms. These Terms apply to all visitors, users and others who access or use the Service.</p>
                <br>
                <p>By accessing or using the Service you agree to be bound by these Terms. If you disagree with any part of the terms then you may not access the Service.</p>
                <br>
                <p style="font-weight: bold;">Content</p>
                <p>Our Service allows you to post, link, store, share and otherwise make available certain information, text, graphics, videos, or other material ("Content").</p>
                <br>
                <p>Our Service may contain links to third-party web sites or services that are not owned or controlled by OurMemory.</p>
                <br>
                <p>OurMemory has no control over, and assumes no responsibility for, the content, privacy policies, or practices of any third party web sites or services. You further acknowledge and agree that OurMemory shall not be responsible or liable, directly or indirectly, for any damage or loss caused or alleged to be caused by or in connection with use of or reliance on any such content, goods or services available on or through any such web sites or services.</p>
                <br>
                <p style="font-weight: bold;">Changes</p>
                <p>We reserve the right, at our sole discretion, to modify or replace these Terms at any time. If a revision is material we will try to provide at least 15 days' notice prior to any new terms taking effect. What constitutes a material change will be determined at our sole discretion.</p>
                <br>
                <p style="font-weight: bold;">Contact Us</p>
                <p>If you have any questions about these Terms, please contact us.</p>
                
                <!-- Terms o service -->
              </div>
            </div>
          </div>
        </div>

        <div class="registration" style="text-align: center;">
          <h1>Registration</h1>
          <br />
          <div class="regBody">
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

              <div style="display:inline;">
                <b-form-group
                  id="firstName.Label"
                  label="First Name:"
                  label-for="firstNameInput"
                  style="display:inline;float:left;width:48%;"
                >
                  <b-form-input
                    id="firstNameInput"
                    v-model="model.firstName"
                    required
                    placeholder="Enter first name"
                  ></b-form-input>
                </b-form-group>
                <b-form-group
                  id="lastName.Label"
                  label="Last Name:"
                  label-for="lastNameInput"
                  style="display:inline;float:right;width:48%;"
                >
                  <b-form-input
                    id="lastNameInput"
                    v-model="model.lastName"
                    required
                    placeholder="Enter last name"
                  ></b-form-input>
                </b-form-group>
              </div>

              <b-form-group
                id="username.Label"
                label="Username:"
                label-for="username"
                :invalid-feedback="usernameError"
              >
                <b-form-input
                  id="username"
                  v-model="model.username"
                  required
                  placeholder="Enter username 8 to 16 characters"
                ></b-form-input>
                <div :v-show="error">{{ model.usernameError }}</div>
              </b-form-group>

              <div style="display:inline;">
                <b-form-group
                  id="passwordLabel"
                  label="Password:"
                  label-for="passwordInput"
                  style="display:inline;float:left;width:48%;"
                >
                  <b-form-input
                    id="passwordInput"
                    v-model="model.password"
                    required
                    placeholder="Enter password with one uppercase, lowercase letter and one digit"
                    type="password"
                  ></b-form-input>
                  <div :v-show="error">{{ model.passwordError }}</div>
                </b-form-group>

                <b-form-group
                  id="confirmPasswordLabel"
                  label="Confirm password:"
                  label-for="ConfirmPasswordInput"
                  style="display:inline;float:right;width:48%;"
                  :invalid-feedback="passwordError"
                  :state="hasError"
                  ><b-form-input
                    id="confirmPasswordInput"
                    v-model="model.confirmPassword"
                    required
                    placeholder="Confirm password"
                    type="password"
                  ></b-form-input>
                </b-form-group>
              </div>

              <br />

              <b-button
                style="width:100%;"
                class="btn btn-lg btn-default smoothScroll wow fadeInUp"
                type="submit"
                variant="warning"
                >Sign up</b-button
              >

              <br /><br />
              <p>
                By signing up, you agree to our<br />
                <a href="#" data-toggle="modal" data-target="#modalImage1"
                  >Terms & Privacy Policy</a
                >
              </p>
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
.regBody {
  width: 50%;
  left: 25%;
  display: inline-block;
}
@media only screen and (max-width: 600px) {
  .regBody {
    width: 100%;
    left: 25%;
    display: inline-block;
  }
}
</style>

<script>
import UserService from "@/components/user-service.js";
export default {
  data() {
    return {
      model: {
        email: "",
        firstName: "",
        lastName: "",
        username: "",
        usernameError: "",
        confirmPassword: "",
        password: "",
        passwordError: ""
      },
      show: true,
      error: false
    };
  },
  methods: {
    async onSubmit(evt) {
      evt.preventDefault();
      this.errorReset();
      let that = this;
      var userService = new UserService();
      var result = await userService
        .register({
          email: this.model.email,
          firstName: this.model.firstName,
          lastName: this.model.lastName,
          username: this.model.username,
          password: this.model.password
        })
        .then(response => {
          that.$router.push("registrationSuccess");
        })
        .catch(error => {
          debugger;
          if (error.response.status == 400) {
            that.error = true;
            if (error.response.data.errors.Password) {
              that.model.passwordError = error.response.data.errors.Password.join(
                " "
              );
            }
            if (error.response.data.errors.Username) {
              that.model.usernameError = error.response.data.errors.Username.join(
                " "
              );
            }
          } else {
            that.$router.push("registrationUnsuccess");
          }
        });
    },
    errorReset() {
      this.model.passwordError = "";
      this.model.usernameError = "";
      this.error = false;
    },
    onReset(evt) {
      evt.preventDefault();
      // Reset our form values
      this.model.email = "";
      this.model.name = "";
      this.errorReset();
      // Trick to reset/clear native browser form validation state
      this.show = false;
      this.$nextTick(() => {
        this.show = true;
      });
    }
  }
};
</script>