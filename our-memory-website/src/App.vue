<template>
  <div id="app">
   
    <!-- Page Preloder -->
	  <div id="preloder">
		  <div class="loader"></div>
	  </div>

    <!-- Nav Bar -->
    <header class="header-section">
		<nav class="navbar navbar-expand-lg navbar-light bg-light fixed-top" role="navigation">
    <div class="container">
        <a class="navbar-brand" href="index.html"><img src="./assets/logo2-trans.png" alt="logo"></a>
        <button class="navbar-toggler border-0" type="button" data-toggle="collapse" data-target="#exCollapsingNavbar">
            &#9776;
        </button>
        <div class="collapse navbar-collapse" id="exCollapsingNavbar">
            <ul class="nav navbar-nav">
                <li class="nav-item"><router-link to="/about" class="nav-link">About</router-link></li>
                <!-- <li class="nav-item"><a href="#" class="nav-link">Link</a></li>
                <li class="nav-item"><a href="#" class="nav-link">Service</a></li>
                <li class="nav-item"><a href="#" class="nav-link">More</a></li> -->
            </ul>
            <ul class="nav navbar-nav flex-row justify-content-between ml-auto">
                <!-- <li class="nav-item order-2 order-md-1"><a href="#" class="nav-link" title="settings"><i class="fa fa-cog fa-fw fa-lg"></i></a></li> -->
                <li class="dropdown order-1">
                    <button type="button" id="dropdownMenu1" data-toggle="dropdown" class="btn btn-outline-secondary dropdown-toggle">Login <span class="caret"></span></button>
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
        </div>
    </div>
</nav>

<div id="modalPassword" class="modal fade" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
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
</div>
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
        console.log("success: " + result.data);
      } else {
        console.log("failure:" + result.status + " | " + result.data);
      }

      alert(JSON.stringify(this.model));
    }
  }
}
</script>
