<template>
  <div>
    <section class="contact-info-one">
      <div class="container">
        <div class="row">
          <div class="col-lg-4">
            <div class="contact-info-one__single wow fadeInDown animated" data-wow-duration="1500ms" style="visibility: visible; animation-duration: 1500ms; animation-name: fadeInDown;">
              <div class="contact-info-one__icon">
                <i class="kipso-icon-manager"></i><!-- /.kipso-icon-manager -->
              </div><!-- /.contact-info-one__icon -->
              <h2 class="contact-info-one__title">About Us </h2><!-- /.contact-info-one__title -->
              <p class="contact-info-one__text">
                Lorem ipsum is simply free text <br> available in the market to
                use <br>
                deliver satisfaction.
              </p><!-- /.contact-info-one__text -->
            </div><!-- /.contact-info-one__single -->
          </div><!-- /.col-lg-4 -->
          <div class="col-lg-4">
            <div class="contact-info-one__single wow fadeInUp animated" data-wow-duration="1500ms" style="visibility: visible; animation-duration: 1500ms; animation-name: fadeInUp;">
              <div class="contact-info-one__icon">
                <i class="kipso-icon-placeholder"></i>
                <!-- /.kipso-icon-manager -->
              </div><!-- /.contact-info-one__icon -->
              <h2 class="contact-info-one__title">Our Address</h2><!-- /.contact-info-one__title -->
              <p class="contact-info-one__text">
                855 Road Broklyn Street, <br>
                600 New York, United States of <br> America
              </p><!-- /.contact-info-one__text -->
            </div><!-- /.contact-info-one__single -->
          </div><!-- /.col-lg-4 -->
          <div class="col-lg-4">
            <div class="contact-info-one__single wow fadeInDown animated" data-wow-duration="1500ms" style="visibility: visible; animation-duration: 1500ms; animation-name: fadeInDown;">
              <div class="contact-info-one__icon">
                <i class="kipso-icon-contact"></i><!-- /.kipso-icon-manager -->
              </div><!-- /.contact-info-one__icon -->
              <h2 class="contact-info-one__title">Contact Info</h2><!-- /.contact-info-one__title -->
              <p class="contact-info-one__text">
                {{translations.CatalystEmail}} <br>
                {{translations.CatalystPhone}} <br> &nbsp;
              </p><!-- /.contact-info-one__text -->
            </div><!-- /.contact-info-one__single -->
          </div><!-- /.col-lg-4 -->
        </div><!-- /.row -->
      </div><!-- /.container -->
    </section>
    <section class="contact-one">
      <div class="container">
        <h2 class="contact-one__title text-center">
          Get in touch <br>
          with us
        </h2><!-- /.contact-one__title -->
        <form @submit.prevent="contact" action="/assets/inc/sendemail.php" class="contact-one__form contact-form-validated" novalidate="novalidate">
          <div class="row low-gutters">
            <div class="col-lg-6">
              <input v-model="registrationData.fullName" type="text" name="fullName" placeholder="Your Name">
            </div><!-- /.col-lg-6 -->
            <div class="col-lg-6">
              <input v-model="registrationData.email"  type="text" placeholder="Email Address" name="email">
            </div><!-- /.col-lg-6 -->
            <div class="col-lg-12">
              <textarea v-model="registrationData.message" placeholder="Write Message" name="message"></textarea>
              <div class="text-center">
                <button type="submit" class="contact-one__btn thm-btn">Submit Comment</button>
              </div><!-- /.text-center -->
            </div><!-- /.col-lg-12 -->
          </div><!-- /.row -->
        </form><!-- /.contact-one__form -->
        <div class="result text-center"></div><!-- /.result -->
      </div><!-- /.container -->
    </section>

        <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2471.6057439723477!2d44.529861505451315!3d40.206816131151065!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x406aa2cdca80cb4b%3A0xcdc047df4f1efc70!2sEurasia%20International%20University!5e0!3m2!1sen!2sam!4v1706870442269!5m2!1sen!2sam" class="google-map__contact" allowfullscreen=""></iframe>
  </div>
</template>

<script>
  import https from 'https';

  export default {
    name: 'Contact',
    methods: {
      async contact() {
        try {
          await this.$axios.post('/api/Contact/Submit', this.registrationData)
            .then(response => {
              console.log(response);
              // Show success or error toast based on response
              if (response.status === 200) {
                this.$toasted.success('Registration successful!');
                setTimeout(() => {
                  window.location = '/contact'; 
                }, 3000);
              } else {
                this.$toasted.error('An unexpected error occurred. Please contact support.'); // Assuming a 'message' property in error response
              }
            })
            .catch(error => {
              // Handle generic errors
              this.$toasted.error('An error occurred during registration. Please try again.');
            });
        } catch (error) {
        }
    },
    },
    async created() {
      await this.$store.dispatch('fetchTranslations');
    },
    computed: {
      translations() {
        return this.$store.state.translations;
      },
    },
    data() {
      return {
        registrationData: { fullName: '', email: '', message: '' },
      };
    },
  };
</script>

<style scoped>

</style>
