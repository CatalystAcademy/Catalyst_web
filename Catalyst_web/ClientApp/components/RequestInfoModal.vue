<template>
  <client-only>
    <b-modal v-model="isModalOpen" :title="translations.RequestInfoModalHeaderText" hide-footer>
      <p class="my-4">{{translations.RequestInfoModalText}}</p>
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
        <b-form-group label="Message"
                      label-for="message-input"
                      invalid-feedback="Message is required">
          <b-form-textarea id="message-input"
                           v-model="createData.message"
                           required>
          </b-form-textarea>
        </b-form-group>
        <button type="submit" class="btn btn-primary">{{translations.RequestMoreInfoBtnText}}</button>
        <button type="button" class="btn btn-secondary" @click="closeModal">{{translations.Cancel}}</button>

      </form>
    </b-modal>
  </client-only>
</template>

<script>
  import https from 'https';
  export default {
    setup() {
      return {
        createData: { phoneNumber: '', email: '', message: '' },
      };
    },
    computed: {
      translations() {
        return this.$store.state.translations;
      },
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
          await this.$axios.post('/api/Form/Submit', this.createData)
            .then(response => {
              // Reset the form fields after successful submission
              this.createData.phoneNumber = '';
              this.createData.email = '';
              this.createData.message = '';

              // Close the modal
              this.$store.dispatch('closeRequestInfoModal');

              // Show success message from backend response
              this.$toasted.success(response.data.message);
            });
        } catch (error) {
          console.error('Error submitting form:', error);
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
