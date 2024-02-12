<template>
  <section class="course-details">
    <div class="container">
      <div class="row">
        <div class="col-lg-12 col-md-6">
          <div class="become-teacher__form">
            <div class="become-teacher__form-top">
              <h2 class="become-teacher__form-title">
                {{translations.ApplyNow}}
              </h2><!-- /.become-teacher__form-title -->
            </div><!-- /.become-teacher__top -->
            <form @submit.prevent="register" action="/assets/inc/sendemail.php" class="become-teacher__form-content contact-form-validated">
              <p>
                <strong>
                  {{translations.ApplySubText}}
                  <br />
                </strong>
                {{translations.ApplyDescription}}
              </p>
              <fieldset>
                <legend>{{translations.StudentInfo}}</legend>
                <input v-model="registrationData.fullName" type="text" :placeholder="translations.FullName" name="fullName" required>
                <input v-model="registrationData.email" type="email" :placeholder="translations.EmailAddress" name="email" required>
                <input v-model="registrationData.phoneNumber" type="text" :placeholder="translations.PhoneNumber" name="phone" required>

                <client-only>
                  <b-form-datepicker id="example-i18n-picker"
                                     v-model="registrationData.DateOfBirth"
                                     :show-decade-nav="showDecadeNav"
                                     :hide-header="hideHeader"
                                     class="mb-2 d-flex align-items-baseline"
                                     :placeholder="translations.DateOfBirth"
                                     menu-class="w-80"
                                     calendar-width="100%"
                                     required>
                  </b-form-datepicker>
                </client-only>

                <input v-model="registrationData.Address" type="text" :placeholder="translations.Address" name="Address" required>
                <input v-model="registrationData.EducationalInstitution" type="text" :placeholder="translations.EducationalInstitution" name="EducationalInstitution" required>
              </fieldset>

              <fieldset>
                <legend>{{translations.ParentInfo}}</legend>
                <input v-model="registrationData.parentPhoneNumber" type="text" :placeholder="translations.ParentPhoneNumber" name="parentPhoneNumber" required>
                <input v-model="registrationData.ParentEmail" type="text" :placeholder="translations.ParentEmail" name="ParentEmail" required>
                <input v-model="registrationData.ParentFullName" type="text" :placeholder="translations.ParentFullName" name="ParentFullName" required>
                <input v-model="registrationData.ParentProfession" type="text" :placeholder="translations.ParentProfession" name="ParentProfession" required>
                <input v-model="registrationData.message" type="text" :placeholder="translations.Comment" name="message" required>
              </fieldset>
              <!-- Consent and Agreement -->
              <div class="consent-agreement">
                <p>
                  <strong>{{translations.ConsentAndAgreement}}</strong>
                  {{translations.ConsentAndAgreementText}}
                </p>
              </div>
              <button type="submit" class="thm-btn become-teacher__form-btn">{{translations.ApplyForBtn}}</button>
            </form><!-- /.become-teacher__form-content -->
            <div class="result text-center"></div><!-- /.result -->
          </div><!-- /.become-teacher__form -->
        </div>
      </div>

    </div><!-- /.container -->
  </section>

</template>


<script>
  import moment from 'moment';

  export default {
    name: "CurriculumDetails",
    methods: {
      scrollToTarget() {
        const targetElement = document.getElementById('register-section');
        targetElement.scrollIntoView({ behavior: 'smooth', block: 'start' });
      },
      async register() {
        try {

          // Send registration data without FormData
          await this.$axios.post('/api/Curriculums/Register', this.registrationData)
            .then(response => {
              // Show success or error toast based on response
              if (response.status === 200) {
                this.$toasted.success(this.translations.registrationsuccessfulMessage);
                setTimeout(() => {
                  window.location = `/apply`; // Redirect after a delay
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
    computed: {
      translations() {
        return this.$store.state.translations;
      },
    },
    data() {
      return {
        value: '',
        showDecadeNav: true,
        hideHeader: true,
        DateOfBirth: null,
        curriculum: {},
        registrationData: { fullName: '', email: '', phoneNumber: '', DateOfBirth: '', parentPhoneNumber: '', address: '', educationalInstitution: '', parentEmail: '', parentFullName: '', parentProfession: '', message: '' },
      };
    },
    async created() {
      await this.$store.dispatch('fetchTranslations');
    }
  };
</script>

<style scoped>
  .become-teacher__form {
    padding-left: 0px !important;
    margin-top: 15px !important;
    position: relative;
  }

  .form-control {
    background-color: #f1f1f1 !important;
    height: auto !important;
  }

  .b-calendar-grid-body .no-gutters .col {
    max-width: 14% !important;
  }

  .col {
    flex-basis: 0;
    flex-grow: 1;
    max-width: 14% !important;
  }

  .no-gutters > .col, .no-gutters > [class*=col-] {
    padding-right: 0;
    padding-left: 0;
    max-width: 14% !important;
  }
</style>
