 <template>
 <div id="index">
    <header>
		<nav id="info">
			<p id="carteira">Minha Carteira</p>
			<nav id="infousu">
				<h2 id="infologin">Bem Vindo, Fulano!</h2>
				<router-link to='/'><span id="logout">Sair</span></router-link>
			</nav>
		</nav>
	</header>
	<div id="container">
		<p>O saldo da sua carteira é: <b>650,00</b></p>
		<nav id="botoes">
			<button id="botao-todas"><router-link to="/index"><b>Todas</b></router-link></button>
			<button id="botao-saques"><router-link to="/saques"><b>Saques</b></router-link></button>
			<button id="botao-depositos"><router-link to="/depositos"><b>Depositos</b></router-link></button>
		</nav>
	</div>
	
    <table>
	<tr id="titulo-tabela">
        <th>Data</th>
        <th>Descrição</th>
        <th>Valor</th>
      </tr>
      <tr class="dados-tabela" v-for="transacaot of saques" :key="transacaot.id">
        <td>{{ transacaot.data }}</td>
        <td>{{ transacaot.descricao }}</td>
        <td style="color: #f00;">{{ formatPrice(transacaot.amount) }}</td>
    </tr>

	</table>

  </div>
</template>
    
<script>
import api from '@/services/config.js'

export default {
 name: 'Saques',

  methods: {
      formatPrice(value) {
        let val = (value/1).toFixed(2).replace('.', ',')
        return val.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ".")
    }
  },

  data() {
    return {
      saques: []
    }
  },
  
  mounted() {
    api.get('/transacoes?tipo=Saque').then(reponse => {
      this.saques = reponse.data;
    });
  }
    
}

</script>
    
<style scoped>
     * {
    font-family: arial;
    color: #4F4F4F;
    
} 

header {
    width: 100%;
    height: 80px;
    justify-content: space-between;
    margin-top: 60px;
}

#info {
    margin: 0;
    display: flex;
    text-align: center;
    align-items: center;
    justify-content: space-between;

}

#infousu {
    margin: 0;
    display: flex;
    text-align: center;
    align-items: center;
    justify-content: space-between;
}

#infologin {
    margin: 0 20px;

    padding-right: 0;
}

#logout {
    font-size: 24px;
    margin: 0 80px;
    margin-left: 10px;

}

a {
    text-decoration: none;
    color: #666261;
}

#carteira {
    margin:0 40px;
    font-size: 35px;
    color: #4F4F4F;
}

#container {
    display: flex;
    margin:0 60px;
    font-size: 20px;
    justify-content: space-between;
}

#botoes {
    margin: 0;
    display: flex;
    text-align: center;
    align-items: center;
}

#botao-todas {
    
    padding-top: 12px;
    padding-left: 28px;
    padding-right: 28px;
    padding-bottom: 12px;
    font-size: 16px;
    color: black;
    border-color: #e6e6e6;
    border-radius: 5px 0px 0px 5px;
}

#botao-todas:hover {
    background-color:  #1E90FF;
}

#botao-saques:hover {
    opacity: 0.9;
}

#botao-saques {
    border-color: #e6e6e6;
    color: black;
    padding: 12px;
    font-size: 16px;
    padding-top: 12px;
    padding-left: 28px;
    padding-right: 28px;
    padding-bottom: 12px;
    background-color: #FFD700;
}

#botao-depositos{
    padding: 12px;
    font-size: 16px;
    border-radius: 0px 5px 5px 0px;
    border-color: #e6e6e6;
    color: black;
    padding-top: 12px;
    padding-left: 28px;
    padding-right: 28px;
    padding-bottom: 12px;
}

#botao-depositos:hover {
    background-color: #FF0000;
}


table {
    width: 92%;
    border-collapse: collapse;
    margin: 0 50px;
}

table, td, th {
border-bottom: 2px solid #ddd;
}

th, td {
color: black;
padding: 20px;
padding-left: 50px;
text-align: left;
}

#titulo-tabela {
    background-color: #ddd;
}

.dados-tabela {
    background-color: #FFFFFF;
}
</style>
    
