<template>
  <section class="mailchimp-one">
        <div class="container">
            <div class="row">
                <div class="col-lg-6">
                    <div class="mailchimp-one__content">
                        <div class="mailchimp-one__icon">
                            <i class="kipso-icon-email"></i><!-- /.kipso-icon-email -->
                        </div><!-- /.mailchimp-one__icon -->
                        <h2 class="mailchimp-one__title">{{translations.GetLatestUpdatesText}}</h2><!-- /.mailchimp-one__title -->
                    </div><!-- /.mailchimp-one__content -->
                </div><!-- /.col-lg-6 -->
                <div class="col-lg-6 d-flex">
                    <div class="my-auto">
                        <form @submit.prevent="submitForm" class="mailchimp-one__form mc-form">
                            <input v-model="createData.email" type="text" id="mc-email" :placeholder="translations.EmailAddress " name="email">
                            <button type="submit" class="thm-btn">{{translations.Subscribe}}</button>
                        </form><!-- /.mailchimp-one__form -->
                        <div class="mc-form__response"></div><!-- /.mc-form__response -->
                    </div><!-- /.my-auto -->
                </div><!-- /.col-lg-6 -->
            </div><!-- /.row -->
        </div><!-- /.container -->
    </section>
</template>

<script>
  import https from 'https';

    export default {
    name: "Subscribe",
    setup() {
      return {
        createData: { email: '' },
      };
    },
    methods: {
      async submitForm() {
        try {
          await this.$axios.post('/api/Form/Submit', this.createData)
            // Show success message
            .then(response => {
              if (response.status === 200) {
                this.$toasted.success('Successfully!');
                setTimeout(() => {
                  window.location = "/"
                }, 3000);
              } else {
                this.$toasted.error('An unexpected error occurred. Please contact support.'); // Assuming a 'message' property in error response
              }
            })
            .catch(error => {
              this.$toasted.error('An error occurred during registration. Please try again.');
            })
        } catch (error) {
          // Handle error and display message
        }
      },
    },
    computed: {
      translations() {
        return this.$store.state.translations;
      },
    },
    async created() {
      await this.$store.dispatch('fetchTranslations');
      // Optional: Set up HTTPS agent for self-signed certificates (if needed)
      if (process.env.NODE_ENV === 'development') {
        this.$axios.defaults.httpsAgent = new https.Agent({ rejectUnauthorized: false });
      }
    },
    }
</script>

<style scoped>

</style>
