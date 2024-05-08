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
              <h2 class="contact-info-one__title">{{translations.OfficeHoursText}} </h2><!-- /.contact-info-one__title -->
              <p class="contact-info-one__text">
                {{translations.Workingdayshours}} <br>
                {{translations.ClosedDay}}
              </p><!-- /.contact-info-one__text -->
            </div><!-- /.contact-info-one__single -->
          </div><!-- /.col-lg-4 -->
          <div class="col-lg-4">
            <div class="contact-info-one__single wow fadeInUp animated" data-wow-duration="1500ms" style="visibility: visible; animation-duration: 1500ms; animation-name: fadeInUp;">
              <div class="contact-info-one__icon">
                <i class="kipso-icon-placeholder"></i>
                <!-- /.kipso-icon-manager -->
              </div><!-- /.contact-info-one__icon -->
              <h2 class="contact-info-one__title">{{translations.OurAddressText}}</h2><!-- /.contact-info-one__title -->
              <p class="contact-info-one__text">
                {{translations.CAAddress}} <br> {{translations.Country}}
              </p><!-- /.contact-info-one__text -->
            </div><!-- /.contact-info-one__single -->
          </div><!-- /.col-lg-4 -->
          <div class="col-lg-4">
            <div class="contact-info-one__single wow fadeInDown animated" data-wow-duration="1500ms" style="visibility: visible; animation-duration: 1500ms; animation-name: fadeInDown;">
              <div class="contact-info-one__icon">
                <i class="kipso-icon-contact"></i><!-- /.kipso-icon-manager -->
              </div><!-- /.contact-info-one__icon -->
              <h2 class="contact-info-one__title">{{translations.ContactInfoText}}</h2><!-- /.contact-info-one__title -->
              <p class="contact-info-one__text">
                <a :href="'mailto:' + 'info@catalystsacademy.com'">{{translations.CatalystEmail}}</a> <br />
                <a :href="'tel:' + '+37441575714'">{{translations.CatalystPhone}}</a>
              </p><!-- /.contact-info-one__text -->
            </div><!-- /.contact-info-one__single -->
          </div><!-- /.col-lg-4 -->
          <div class="col-lg-4 mt-5">
            <div class="contact-info-one__single wow fadeInUp animated" data-wow-duration="1500ms" style="visibility: visible; animation-duration: 1500ms; animation-name: fadeInUp;">
              <div class="contact-info-one__icon">
                <i class="kipso-icon-bottom-arrow"></i>
                <!-- /.kipso-icon-manager -->
              </div><!-- /.contact-info-one__icon -->
              <h2 class="contact-info-one__title">{{translations.GetTouch}}</h2><!-- /.contact-info-one__title -->
              <p class="contact-info-one__text">
                {{translations.GetTouchMainText}}
                <br />
                <nuxt-link to="#getInTouch">{{translations.FillFormText}}</nuxt-link>
              </p><!-- /.contact-info-one__text -->
            </div><!-- /.contact-info-one__single -->
          </div><!-- /.col-lg-4 -->
          <div class="col-lg-4 mt-5">
            <div class="contact-info-one__single wow fadeInUp animated" data-wow-duration="1500ms" style="visibility: visible; animation-duration: 1500ms; animation-name: fadeInDown;">
              <div class="contact-info-one__icon">
                <i class="kipso-icon-right-arrow"></i>
                <!-- /.kipso-icon-manager -->
              </div><!-- /.contact-info-one__icon -->
              <h2 class="contact-info-one__title">{{translations.VisitUs}}</h2><!-- /.contact-info-one__title -->
              <p class="contact-info-one__text">
                {{translations.VisitUsText}}
                <nuxt-link to="/onSiteVisit">{{translations.HereText}}</nuxt-link>
              </p><!-- /.contact-info-one__text -->
            </div><!-- /.contact-info-one__single -->
          </div><!-- /.col-lg-4 -->
          <div class="col-lg-4 mt-5">
            <div class="contact-info-one__single wow fadeInUp animated" data-wow-duration="1500ms" style="visibility: visible; animation-duration: 1500ms; animation-name: fadeInUp;">
              <div class="contact-info-one__icon">
                <i class="kipso-icon-strategy"></i>
                <!-- /.kipso-icon-manager -->
              </div><!-- /.contact-info-one__icon -->
              <h2 class="contact-info-one__title">
                {{translations.FollowUsText}}
              </h2><!-- /.contact-info-one__title -->
              <p class="contact-info-one__text">
                {{translations.FollowUsDesc}}
                <div class="header__social-custom">
                  <a href="https://www.facebook.com/catalystacademyarmenia?mibextid=ZbWKwL" target="_blank"><i class="fab fa-facebook-square"></i></a>
                  <a href="https://www.instagram.com/catalystsacademy?igsh=MTRwOWhuOHFtMzRpZg==" target="_blank"><i class="fab fa-instagram"></i></a>
                  <a href="https://www.linkedin.com/company/catalystsacademy/" target="_blank"><i class="fab fa-linkedin"></i></a>
                </div><!-- /.header__social -->
              </p><!-- /.contact-info-one__text -->
            </div><!-- /.contact-info-one__single -->
          </div><!-- /.col-lg-4 -->
        </div><!-- /.row -->
      </div><!-- /.container -->
    </section>
    <section class="contact-one" id="getInTouch">
      <div class="container">
        <h2 class="contact-one__title text-center">
          {{
translations.GetTouch
          }} <br>
          {{translations.WithUs}}
        </h2><!-- /.contact-one__title -->
        <p class="about-one__text mt-5 mb-5">
          {{translations.ContactUsText}}
        </p><!-- /.about-one__text -->
        <form @submit.prevent="contact" action="/assets/inc/sendemail.php" class="contact-one__form contact-form-validated" novalidate="novalidate">
          <div class="row low-gutters">
            <div class="col-lg-6">
              <input v-model="registrationData.fullName" type="text" name="fullName" :placeholder="translations.FullName">
            </div><!-- /.col-lg-6 -->
            <div class="col-lg-6">
              <input v-model="registrationData.email" type="text" :placeholder="translations.EmailAddress" name="email">
            </div><!-- /.col-lg-6 -->
            <div class="col-lg-12">
              <textarea v-model="registrationData.message" :placeholder="translations.Message" name="message"></textarea>
              <div class="text-center">
                <button type="submit" class="contact-one__btn thm-btn">{{translations.SendMessage}}</button>
              </div><!-- /.text-center -->
            </div><!-- /.col-lg-12 -->
          </div><!-- /.row -->
        </form><!-- /.contact-one__form -->
        <div class="result text-center"></div><!-- /.result -->
      </div><!-- /.container -->
    </section>
    <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3047.040296275678!2d44.52893257469827!3d40.208166571473946!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x406aa346a5a15bc3%3A0xa2fb565adfce929f!2sCatalyst%20Academy!5e0!3m2!1sru!2sam!4v1710234580249!5m2!1sru!2sam" class="google-map__contact" allowfullscreen=""></iframe>
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
                this.$toasted.success(this.translations.FormSuccessfullSubmisionForm);
                setTimeout(() => {
                  window.location = '/contact'; 
                }, 3000);
              } else {
                this.$toasted.error(this.translations.registrationErrorMessage); // Assuming a 'message' property in error response
              }
            })
            .catch(error => {
              // Handle generic errors
              this.$toasted.error(this.translations.registrationErrorMessage);
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
  .header__social-custom {
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
/*    margin-left: 90px;
*/    margin-top: 7px;
      margin-bottom: 0px;
  }

    .header__social-custom a {
      color: #81868a;
      font-size: 18px;
      -webkit-transition: all .4s ease;
      transition: all .4s ease;
    }

      .header__social-custom a:hover {
        color: #f16101;
      }

      .header__social-custom a + a {
        margin-left: 30px;
      }

</style>
