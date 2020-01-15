<template>
  <div id="app">
   

    <!-- Page Preloder -->
	  <div id="preloder">
		  <div class="loader"></div>
	  </div>

    <!-- Nav Bar -->
    <header class="header-section">
		<nav id="theTopHeader" class="navbar navbar-expand-lg navbar-light fixed-top color" role="navigation" style="background-color:#5F3076;">
    <div class="container" style=" padding: 0; border: 0; margin: 0; width:100%;" >

        <a class="navbar-brand" href="index.html"><img src="./assets/logo3-trans.png" alt="logo"></a>

        <button class="navbar-toggler border-0" type="button" data-toggle="collapse" data-target="#exCollapsingNavbar">
            &#9776;
        </button>

        <ul class="nav navbar-nav flex-row justify-content-between" style="position: absolute; top: 16px; right: 15%; "> 
                <!-- <li class="nav-item order-2 order-md-1"><a href="#" class="nav-link" title="settings"><i class="fa fa-cog fa-fw fa-lg"></i></a></li> -->
                <li class="dropdown order-1" >
                    <button type="button" id="dropdownMenu1" data-toggle="dropdown" class="btn btn-outline-secondary dropdown-toggle" style="color:white;">Login <span class="caret"></span></button>
                    <ul class="dropdown-menu dropdown-menu-right mt-2">
                       <li class="px-3 py-2">
                           <form class="form" role="form">
                                <div class="form-group">
                                    <input v-model="model.username" id="usernameInput" placeholder="Username" class="form-control form-control-sm" type="text" required="">
                                </div>
                                <div class="form-group">
                                    <input v-model="model.password" id="passwordInput" placeholder="Password" class="form-control form-control-sm" type="text" required="">
                                </div>
                                <div class="form-group">
                                    <button type="submit" v-on:click="login" class="btn btn-primary btn-block">Login</button>
                                </div>
								<div class="form-group text-center">
                                    <small><router-link to="/registration"> Register</router-link></small>
                                </div>
                                <div class="form-group text-center">
                                    <small><a href="#" data-toggle="modal" data-target="#modalPassword">Forgot password?</a></small>
                                </div>
                            </form>
                        </li>
                    </ul>
                </li>
        </ul>

        <div class="collapse navbar-collapse" id="exCollapsingNavbar" >
            <ul class="nav navbar-nav" >
                <li class="nav-item"><router-link to="/about" class="nav-link" style="color:white;">About</router-link></li>
                <li class="nav-item"><router-link to="/Dashboard" class="nav-link" style="color:white;">My Dashboard</router-link></li>
                <li class="nav-item"><router-link to="/RegistrationSuccess" class="nav-link" style="color:white;">Reg-Success [REMOVE]</router-link></li>
                <li class="nav-item"><router-link to="/RegistrationUnSuccess" class="nav-link" style="color:white;">Reg-UnSuccess [REMOVE]</router-link></li>
                <!-- <li class="nav-item"><a href="#" class="nav-link">Link</a></li>
                <li class="nav-item"><a href="#" class="nav-link">Service</a></li>
                <li class="nav-item"><a href="#" class="nav-link">More</a></li> -->
            </ul>
            
            

        </div>
    </div>
</nav>

<!-- <div id="modalPassword" class="modal fade" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <h3>Forgot password</h3>
                <button type="button" class="close font-weight-light" data-dismiss="modal" aria-hidden="true">×</button>
            </div>
            <div class="modal-body">
                <p>Reset your password..</p>
            </div>
            <div class="modal-footer">
                <button class="btn" data-dismiss="modal" aria-hidden="true">Close</button>
                <button class="btn btn-primary">Save changes</button>
            </div>
        </div>
    </div>
</div> -->

	  <!-- <a href="index.html" class="site-logo"><img src="./assets/logo2-trans.png" alt="logo"></a>
      
        <div class="header-controls">
			  <button class="nav-switch-btn"><i class="fa fa-bars"></i></button>
		</div>

        <ul class="main-menu">
			<li><router-link to="/">Home</router-link></li>
			<li><router-link to="/about"> About</router-link></li> -->
			<!-- <li>
				<a href="#">Portfolio</a>
				<ul class="sub-menu">
					<li><a href="portfolio.html">Portfolio 1</a></li>
					<li><a href="portfolio-1.html">Portfolio 2</a></li>
					<li><a href="portfolio-2.html">Portfolio 3</a></li>
				</ul>
			</li> -->
			<!-- <li><router-link to="/registration"> Register</router-link></li>
		</ul> -->

	</header>
	<div class="clearfix"></div>
    <router-view />

<!-- Footer section   -->
	<footer class="footer-section">
		<div class="container-fluid">
			<div class="row">
				<div class="col-md-6 order-1 order-md-2">
					<div class="footer-social-links">
						<a href=""><i class="fa fa-pinterest"></i></a>
						<a href=""><i class="fa fa-facebook"></i></a>
						<a href=""><i class="fa fa-twitter"></i></a>
						<a href=""><i class="fa fa-instagram"></i></a>
					</div>
				</div>
				<div class="col-md-6 order-2 order-md-1">
					<div class="copyright">
              Designed by: Finite Reality Tech Co. - 2020
          </div>	
				</div>
			</div>
		</div>
	</footer>
	<!-- Footer section end  -->

  </div>
</template>

<script>
import UserService from "@/components/user-service";

    export default {
        data() {
    return {
      model: {
        username: '',
        password: '',
      },
      show: true
    };
  },
  methods: {
    async login(evt) {
      evt.preventDefault();

       var service = new UserService();
       var result = await service.authenticate({
        "username": this.model.username,
        "password": this.model.password
      });

    if (result.status == 200) {
        this.$router.push('dashboard');
      } else {
        // TODO: Display error message.
      }
    }
  }
}
</script>
