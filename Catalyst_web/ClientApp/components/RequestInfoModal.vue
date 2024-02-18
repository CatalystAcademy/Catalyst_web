<template>
  <client-only>
    <b-modal v-model="isModalOpen" title="Request Info" @hidden="closeModal">
      <form @submit.prevent="submitRequest" action="/assets/inc/sendemail.php">
        <b-form-group label="Phone Number"
                      label-for="phoneNumber-input"
                      invalid-feedback="Phone Number is required">
          <b-form-input id="phoneNumber-input"
                        v-model="createData.phoneNumber"
                        required>
          </b-form-input>
        </b-form-group>
        <b-form-group label="Email"
                      label-for="email-input"
                      invalid-feedback="Email is required">
          <b-form-input id="email-input"
                        v-model="createData.email"
                        required>
          </b-form-input>
        </b-form-group>
      </form>
    </b-modal>
  </client-only>
</template>

<script>
  import https from 'https';
  export default {
    setup() {
      return {
        createData: { phoneNumber: '', email: '' },
      };
    },
    computed: {
      isModalOpen: {
        get() {
          return this.$store.state.isRequestInfoModalOpen;
        },
        set(value) {
          // You can perform additional logic when the modal state changes
          this.$store.commit('setRequestInfoModalState', value);
        },
      },
    },
    methods: {
      async submitRequest() {
        try {
          await this.$axios.post('/api/Form/Submit', this.createData).then(function (response) {
            if (response) {
              console.log(response);
            }
          })
            .catch(function (error) {
            })
          this.$store.dispatch('closeRequestInfoModal');
        } catch (error) {
          console.error('Error submitting form:', error);
        }
      },
      closeModal() {
        // Ensure the form is cleared when the modal is closed
        this.phoneNumber = '';
        this.email = '';
      },
    },
    created() {
      // Optional: Set up HTTPS agent for self-signed certificates (if needed)
      if (process.env.NODE_ENV === 'development') {
        this.$axios.defaults.httpsAgent = new https.Agent({ rejectUnauthorized: false });
      }
    },
  };
</script>

<style module>
  
</style>
