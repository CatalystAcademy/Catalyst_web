<template>
  <section class="on-site-visit">
    <div class="container">
      <div class="row" id="register-section">
        <div class="col-lg-12">
          <div class="become-teacher__form">
            <div class="become-teacher__form-top">
              <h2 class="become-teacher__form-title">
                Schedule an On-Site Visit to Catalyst Academy
              </h2><!-- /.become-teacher__form-title -->
            </div><!-- /.become-teacher__top -->
            <form @submit.prevent="submitForm" action="/assets/inc/sendemail.php" class="become-teacher__form-content contact-form-validated">
                <p>
              <strong>
              Visit Details
              </strong>
                </p>
                <ul>
                  <li>
                    Tour Availability: Tours are available Monday to Friday from 9:00 AM to 5:00 PM.
                  </li>
                  <li>

                    Advance Booking: To ensure availability, please schedule your visit at least 2 days in advance using the form below.
                  </li>
                </ul>
              <input v-model="registrationData.name" type="text" placeholder="Your full Name" name="fullName" required>
              <input v-model="registrationData.email" type="email" placeholder="Email Address" name="email" required>
              <input v-model="registrationData.phoneNumber" type="text" placeholder="Phone Number" name="phone" required>

              <client-only>
                <b-form-datepicker id="example-i18n-picker"
                                   v-model="registrationData.appointmentDate"
                                   :show-decade-nav="showDecadeNav"
                                   :hide-header="hideHeader"
                                   class="mb-2 h-auto d-flex align-items-baseline"
                                   placeholder="Visit Date"
                                   menu-class="w-80"
                                   calendar-width="100%"
                                   aria-required="true"
                                   :min="minDate">
                </b-form-datepicker>

                <b-form-timepicker v-model="registrationData.appointmentTime"
                                   class="mb-2 h-auto d-flex align-items-baseline"></b-form-timepicker>

              </client-only>

              <button type="submit" class="thm-btn become-teacher__form-btn">Make appointment </button>
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
        appointmentTime: null,
      },
    };
    },
    computed: {
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
      console.log('Form submitted with data:', this.formData);
      // Reset form after submission
    },
  },
};
</script>

<style>
  .on-site-visit {
    margin-top: 6rem;
    margin-bottom: 2rem;
  }
</style>
