<template>
  <section class="on-site-visit">
    <div class="container">
      <div class="row">
        <div class="col-lg-12">
          <div class="become-teacher__form">
            <div class="become-teacher__form-top">
              <h2 class="become-teacher__form-title">
                {{translations.OnSiteVisitText}}
              </h2><!-- /.become-teacher__form-title -->
            </div><!-- /.become-teacher__top -->
            <form @submit.prevent="submitForm" action="/assets/inc/sendemail.php" class="become-teacher__form-content contact-form-validated">
              <p>
                {{translations.OnSiteVisitDescription}}
                <br />
                <strong>
                  {{translations.OnSiteVisitSubText}}
                </strong>
                </p>
                <ul>
                  <li>
                    <strong>
                      {{translations.OnSiteVisitOneLabel}}
                    </strong>{{translations.OnSiteVisitTextOne}}
                  </li>
                  <li>
                    <strong>
                      {{translations.OnSiteVisitTwoLabel}}
                    </strong>{{translations.OnSiteVisitTextTwo}}
                  </li>  
                  <li>
                    <strong>
                      {{translations.OnSiteVisitThreeLabel}}
                    </strong>{{translations.OnSiteVisitTextThree}}
                  </li>  
                  <li>
                    <strong>
                      {{translations.OnSiteVisitFourLabel}}
                    </strong>{{translations.OnSiteVisitTextFour}}
                  </li>                
                </ul>
                <p>{{translations.OnSiteVisitFooterText}}</p>
              <input v-model="registrationData.name" type="text" :placeholder="translations.FullName" name="fullName" required>
              <input v-model="registrationData.email" type="email" :placeholder="translations.EmailAddress" name="email" required>
              <input v-model="registrationData.phoneNumber" type="text" :placeholder="translations.PhoneNumber" name="phone" required>
              <client-only>
                <b-form-datepicker id="example-i18n-picker"
                                   v-model="registrationData.appointmentDate"
                                   :show-decade-nav="showDecadeNav"
                                   :hide-header="hideHeader"
                                   class="mb-2 h-auto d-flex align-items-baseline"
                                   :placeholder="translations.VisitDate"
                                   menu-class=""
                                   calendar-width="350px"
                                   aria-required="true"
                                   :min="minDate">
                </b-form-datepicker>
                  <b-form-timepicker v-model="registrationData.appointmentTime"
                                     :default-value="defaultTime"
                                     class="mb-2 h-auto d-flex align-items-baseline justify-content-end"
                                     menu-class=""
                                     dropup
                                     now-button
                                     reset-button
                                     no-flip
                                     :required="true"
                                     :placeholder="translations.VisitTime">
                  </b-form-timepicker>
              </client-only>
              <button type="submit" class="thm-btn become-teacher__form-btn">{{translations.MakeAppointmentBtn}} </button>
            </form><!-- /.become-teacher__form-content -->
            <div class="result text-center"></div><!-- /.result -->
          </div><!-- /.become-teacher__form -->
        </div>
      </div>
    </div>
    </section>
</template>
<script>
  export default {
    name: 'OnSiteVisit',
  data() {
    return {
      showDecadeNav: true,
      hideHeader: true,
      registrationData: {
        name: '',
        email: '',
        phoneNumber: '',
        appointmentDate: null,
        appointmentTime: '15:00:00',
      },
      defaultTime: '15:00:00',
    };
    },
    computed: {
      translations() {
        return this.$store.state.translations;
      },
      minDate() {
        const today = new Date();
        // Calculate the minimum date by adding 2 days to today's date
        const minDate = new Date(today);
        minDate.setDate(minDate.getDate() + 2);
        // Return the minimum date in ISO format (YYYY-MM-DD) expected by <b-form-datepicker>
        return minDate.toISOString().split('T')[0];
      }
    },
  methods: {
    async submitForm() {
      await this.$axios.post('/api/Visit/Submit', this.registrationData)
        .then(response => {
          // Show success or error toast based on response
          if (response.status === 200) {
            this.$toasted.success(this.translations.registrationsuccessfulMessage);
            setTimeout(() => {
              window.location = `/onSiteVisit`; // Redirect after a delay
            }, 3000);
          } else {
            this.$toasted.error(this.translations.registrationErrorMessage); // Assuming a 'message' property in error response
          }
        })
        .catch(error => {
          if (error.response && error.response.status === 400 && error.response.data.errors) {
            const errorMessages = Object.values(error.response.data.errors)[0];
            console.log(errorMessages);
            // Join all error messages into a single string
            const errorMessage = errorMessages;
            this.$toasted.error(errorMessage);
          } else {
            this.$toasted.error(this.translations.registrationErrorMessage);
          }
        });
    },
    },
    async created() {
      await this.$store.dispatch('fetchTranslations');
    }
};
</script>
<style>
  .on-site-visit {
    margin-top: 6rem;
    margin-bottom: 2rem;
  }
  .d-inline-flex {
    display: -ms-inline-flexbox !important;
    display: inline-table !important;
  }
  .b-form-date-controls button {
      margin-top: 10px;
  }
  .flex-grow-1 {
    margin-left: 0.6rem;
  }
</style>
