<template>
    <div class="login">
        <center><div id="login">
		<form @submit.prevent="login">

			<h2 id="identidade">Identifique-se</h2>
			<img id="fotousuario" src="@/img/usuarioimg.png"><input id="username" v-model="email" class="form-input" type="text" name="Username" placeholder="Username"><br>
			<img id="password" src="@/img/key.png"><input id="userpassword" v-model="senha" class="form-input" type="password" name="Password" placeholder="Password"><br>
			
			<button type="submit">Entrar</button>
		</form>
	</div>
	</center>
    </div>
</template>

<script>

export default ({
    name: 'Login',
	data() {
		return {
			email: '',
			senha: ''
		}
	},
	methods: {
		login() {
			this.$router.push('/index')
		}
	}
	
	
})

</script>

<style scoped>
	body {
	background-color: #ddd;
	font-family: sans-serif;
	}

#login {
	height: 300px;
	width: 400px;
	justify-content: center;
	margin-top: 12%;
	margin-bottom: 12%;
	background-color: #ffffff;
	border: 1px solid #ffffff;
	border-radius: 5px;

}

.form-input {
	padding: 10px;
}
#username {
	margin-top: 100px; 
	color: black;
	border: 1px solid #ddd;
}

#userpassword {
	color: black;
	border: 1px solid #ddd;
}
#password {
	margin-top: 20px;
	color: #ddd;
	border: 1px solid #ddd;
	background-color: #ddd;
	width: 25px;
	height: 25px;
	border: 1px solid #ddd;
	padding: 6px;
	border-radius: 0px 0px 0px 0px;
	margin-bottom: -15px;
}

#identidade {
	position: absolute;
	margin: 0;
	padding: 12px;
	font-size: 35px;
}

button {
	width: 250px;
	margin-top: 30px;
	background-color: #32CD32;
	color: #ffffff;
	padding-left: 50px;
	padding-right: 50px;
	padding-top: 10px;
	padding-bottom: 15px;
	border: 1px solid #32CD32;
	border-radius: 5px;
}

#fotousuario {
	background-color: #ddd;
	width: 25px;
	height: 25px;
	border: 1px solid #ddd;
	padding: 6px;
	border-radius: 4px 0px 0px 4px;
	margin-bottom: -15px;
}

</style>