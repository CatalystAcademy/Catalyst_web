<template>
  <client-only>
    <b-modal id="modal-1" v-model="isModalOpen" title="BootstrapVue" hide-footer modal-class="no-modal-backdrop">
      <form @submit.prevent="$auth.loginWith('admin', { data: { username: username, email: email, password: password} })">
        <b-form-group label="Email"
                      label-for="Email-input"
                      invalid-feedback="Email is required">
          <input type="text" v-model="email" placeholder="Email">
        </b-form-group>
        <b-form-group label="Password"
                      label-for="Password-input"
                      invalid-feedback="Password is required">
          <input type="text" v-model="password" placeholder="Password">
        </b-form-group>
          <button type="submit" class="btn btn-primary">Login</button>
      </form>
    </b-modal>
  </client-only>
</template>

<script>
  import https from 'https';
  export default {
    data() {
      return {
        email: '',
        password: '',
        username: ''
      };
    },
    computed: {
      translations() {
        return this.$store.state.translations;
      },
      isModalOpen: {
        get() {
          return this.$store.state.isLoginModalOpen;
        },
        set(value) {
          // You can perform additional logic when the modal state changes
          this.$store.commit('setLoginModalState', value);
        },
      },
    },
    methods: {
      async login() {
        try {
          await this.$auth.loginWith('admin', { data: { username: this.username, email: this.email, password: this.password } });
          this.$router.push('/'); // Redirect to home page after successful login
        } catch (error) {
          console.error('Login error:', error);
          if (error.response && error.response.status === 401) {
            this.loginError = "Invalid username or password"; // Display user-friendly message
          }
        }
      },
      closeModal() {
        // Close the modal
        this.isModalOpen = false;
      },
    },
    async created() {
      await this.$store.dispatch('fetchTranslations');
      if (process.env.NODE_ENV === 'development') {
        this.$axios.defaults.httpsAgent = new https.Agent({ rejectUnauthorized: false });
      }
    },
  };
</script>

<style module>
</style>
